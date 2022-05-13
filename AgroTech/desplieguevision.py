def PrediccionFresa(namefile):
  import numpy as np
  import pandas as pd
  import matplotlib.pyplot as plt

  import requests as req
  from io import BytesIO
  from PIL import Image
  import os, sys
  import cv2

  from tensorflow import keras
  model_deep = keras.models.load_model('model_deep.h5')
  model_deep.summary()
  import pickle

  filename='labelencoder.pkl'
  labelencoder= pickle.load(open(filename, 'rb'))

  mat_hist=[]
  nombres=[]

  response = req.get(namefile)
  img = Image.open(BytesIO(response.content))
  img = img.resize((300,300))

  hist = img.histogram()

  mat_hist.append(hist)

  prediccion_fresassanas=pd.DataFrame(mat_hist)

  data = pd.concat([prediccion_fresassanas], axis=0)

  Y_fut = model_deep.predict(data) 

  Y_fut=np.argmax(Y_fut, axis=1)

  return (labelencoder.inverse_transform(Y_fut))