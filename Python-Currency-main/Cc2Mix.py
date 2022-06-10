
from pymongo import MongoClient
import pymongo
import os
import requests
from requests.api import post
import Alert
from datetime import date
from forex_python.converter import get_rate
from bs4  import BeautifulSoup

os.system('cls')

cluster=MongoClient('Your Mongo Pass+The line')
db=cluster["Python"] #name u choose
collection=db["test"] #name u choose


post={"_id":0,"name":"jonny","Currnecy-":0}
#post2={"_id":cc.count,"name":"jonny","old":cc.a}

#צריך להוסיף תנאים אם קיים תדרוס או תפתח חדש

collection.insert_many([post])

# Where USD is the base currency you want to use
url = 'https://v6.exchangerate-api.com/v6/c13a1dcc0116f9dc56ca309e/latest/USD' # the site you choose to follow currency

# Making our request
response = requests.get(url)
data = response.json()
count=0
a=0
b=data
k=1

# Your JSON object
#לא מצליח להפריד ב CURRENCY שיהיה רק סוג 1

while(k!=0):
  response = requests.get(url)
  data = response.json()
  b=data
  print("Looping") #check if loop working (better delete if in use for less work to cpu)
  if(a!=b):
     print("+_+Alert Alert+_+")#checking if its working delete or (#)
     a=b
     count+=2
     post={"_id":count,"name":"jonny","Currnecy-":a}
     collection.insert_many([post])
     Alert.email_alert("Currnecy","Chang","The Mail You want Send To")
     
