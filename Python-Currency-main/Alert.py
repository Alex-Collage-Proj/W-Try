import smtplib
from email.message import EmailMessage
import random
import requests
from bs4  import BeautifulSoup

def email_alert(subject,body,to):
    msg=EmailMessage()
    msg.set_content(body)
    msg['subject']=subject
    msg['to']= to
    
    
    user="Your Mail That you want send from"
    msg['from']="user"
    password="yourpass(google speciel pass)"
    
    server= smtplib.SMTP("smtp.gmail.com",587)
    server.starttls()
    server.login(user,password)
    server.send_message(msg)

    server.quit()

    if __name__=='__main__':
        email_alert("hey","hello world","The Mail You Want TO send To")
        
