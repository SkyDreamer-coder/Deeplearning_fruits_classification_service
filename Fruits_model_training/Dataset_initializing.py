# -*- coding: utf-8 -*-
"""
Created on Mon Dec 19 16:54:02 2022

@author: Ryko
"""
from Required_Libraries import *

# defining data directories
train_dir="fruits-360_dataset/fruits-360/Training/"
test_dir="fruits-360_dataset/fruits-360/Test/"

# image size assignment
img = load_img(train_dir + "Cherry 2/1_100.jpg")
plt.imshow(img)
plt.show()

x= img_to_array(img)
print("x.shape is : ", x.shape)
# class lenght assignmetnt
classname= glob(train_dir + "/*")
numberofclass = len(classname)
print("number of class is :",numberofclass)

