# -*- coding: utf-8 -*-
"""
Created on Mon Dec 19 18:38:29 2022

@author: Ryko
"""

from abc import ABC,abstractmethod
from Dataset_initializing import*
import json
import codecs

class Fruits_factory(ABC):
    
    @abstractmethod
    def ModelCreator(self):
        pass
    @abstractmethod
    def Display(fileName):
        pass
    @abstractmethod
    def ModelExporter(self,model_name):
        pass
    
class Cherry(Fruits_factory):
    
    _batchSize =0
    _epochNum  =0
    
    def __init__(self,batchSize,epochNum):
        
        self._batchSize=batchSize
        self._epochNum=epochNum
        
    def ModelCreator(self):
        
        Fruits_model = Sequential()
        
        Fruits_model.add(Conv2D(32,(3,3),input_shape=(100,100,3)))
        Fruits_model.add(Activation("relu"))
        Fruits_model.add(MaxPooling2D())
        
        Fruits_model.add(Conv2D(32,(3,3)))
        Fruits_model.add(Activation("relu"))
        Fruits_model.add(MaxPooling2D())
        
        Fruits_model.add(Conv2D(64,(3,3)))
        Fruits_model.add(Activation("relu"))
        Fruits_model.add(MaxPooling2D())
        
        Fruits_model.add(Conv2D(64,(3,3)))
        Fruits_model.add(Activation("relu"))
        Fruits_model.add(MaxPooling2D())
        
        Fruits_model.add(Conv2D(128,(3,3)))
        Fruits_model.add(Activation("relu"))
        Fruits_model.add(MaxPooling2D())
        
        Fruits_model.add(Flatten())
        Fruits_model.add(Dense(1024))
        Fruits_model.add(Activation("relu"))
        Fruits_model.add(Dropout(0.5))
        Fruits_model.add(Dense(numberofclass))
        Fruits_model.add(Activation("softmax"))        
        
        
        Fruits_model.compile(loss="categorical_crossentropy",
                             optimizer = "rmsprop",
                             metrics = ["accuracy"])
        
        
        # using data augmentation
        Fr_train_datagen=ImageDataGenerator(rescale=1./255,
                                        width_shift_range=0.3,
                                        height_shift_range=0.3,
                                        shear_range=0.2,
                                        zoom_range=0.3,
                                        horizontal_flip=True)
   
        Fr_test_datagen=ImageDataGenerator(rescale=1./255)
   
        Fr_train_generator=Fr_train_datagen.flow_from_directory(train_dir,
                                       target_size=(100,100),
                                       batch_size=self._batchSize,
                                       color_mode="rgb",
                                       class_mode="categorical")
   
        Fr_test_generator = Fr_test_datagen.flow_from_directory(test_dir,
                                                     target_size=(100,100),
                                                     batch_size=self._batchSize,
                                                     color_mode="rgb",
                                                     class_mode="categorical")
        
        # model fitting
        Fr_hist=Fruits_model.fit(Fr_train_generator,
                                  steps_per_epoch=2600//self._batchSize,
                                  epochs=self._epochNum,
                                  validation_data=Fr_test_generator,
                                  validation_steps=1000//self._batchSize)
        
        #model saving
        Fruits_model.save("fruits_model.h5")
        
        #saving model history
        with open("fruits_model.json","w") as f:
            json.dump(Fr_hist.history,f)
        
        
    def Display(self,fileName):
        
        with codecs.open(fileName,"r",encoding="utf-8") as f:
            h = json.loads(f.read())
        
        # model visualization with pylot
        plt.plot(h["accuracy"],label="acc")
        plt.plot(h["val_accuracy"],label="val_acc")
        plt.title('batch='+str(self._batchSize),pad=-40)
        plt.legend()
        plt.show()

        plt.figure()

        plt.plot(h["loss"],label="loss")
        plt.plot(h["val_loss"],label="val_loss")
        plt.title('batch='+str(self._batchSize),pad=-40)
        plt.legend()
        plt.show()
        
        
    def ModelExporter(self,model_name):
        
        model = load_model(model_name)
        tf.saved_model.save(model,"tmp_model")
       
        
        
        
        
