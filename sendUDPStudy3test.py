# -*- coding: utf-8 -*-
"""
Created on Wed Feb  8 16:04:59 2023

@author: thoma
"""

import socket

quitList = ['Quit', 'quit', 'Q', 'q']



#127.0.0.1 - Localhost
#169.254.21.197 - Hololens Ethernet
#192.168.1.100 - TPLink address

UDP_IP = "127.0.0.1"
UDP_PORT = 5006
running = True
inputList = []


while running == True:

    message = input("Message to send: ")
    inputList.append(message)
    
    
    if message in quitList:
        print("")
        print(":Quitting Program:")
        running = False
        

    else:
        print("UDP target IP:", UDP_IP)
        print("UDP target port:", UDP_PORT)
        print("message:", message)
        
        sock = socket.socket(socket.AF_INET, socket.SOCK_DGRAM) # UDP
        sock.sendto(bytes(message, "utf-8"), (UDP_IP, UDP_PORT))
        
       
        