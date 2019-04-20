'''import playsound
playsound.playsound('ex021.mp3')'''

import pygame
pygame.mixer.init()
pygame.mixer.music.load('ex021.mp3')
pygame.mixer.music.play()
x = input('Digite algo para parar!')
