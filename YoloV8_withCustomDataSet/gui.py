import cv2
import threading
import sys

from PyQt5 import QtGui
import time
from PyQt5.QtWidgets import *
from PyQt5.QtGui import *
from PyQt5.QtCore import *
from PyQt5 import uic
import detect as dt

class BackgroungWorker(QThread) : 
    procChanged = pyqtSignal(QtGui.QPixmap)

    def __init__(self,parent = None):
        super().__init__()
        self.main = parent
        self.running = False 
        self.cap = cv2.VideoCapture(0)
        
    def run(self) :
        while self.running:
            ret, frame = self.cap.read()
            if not ret:
                break
            # frame = dt.yolomodel_frame(frame)    
            frame = cv2.cvtColor(frame, cv2.COLOR_BGR2RGB)

            h,w,c = frame.shape           
            qImg = QtGui.QImage(frame.data, w, h, w*c, QtGui.QImage.Format_RGB888)
            self.pixmap = QtGui.QPixmap.fromImage(qImg)
            self.procChanged.emit(self.pixmap)
        self.cap.release()

class qtApp(QMainWindow) : 
    def __init__(self) :
        super().__init__()
        uic.loadUi('PlateDetectApp.ui',self)
        self.thread = BackgroungWorker()

        self.thread.start() 
        self.thread.running = True
        self.thread.procChanged.connect(self.procUpdated)

    def procUpdated(self, img) :
        self.lblImg.setPixmap(img)

if __name__ == '__main__' :    
    app = QApplication(sys.argv)
    ex = qtApp()
    ex.show()
    sys.exit(app.exec_())