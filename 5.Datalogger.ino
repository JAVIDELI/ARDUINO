//Escribe en una tarjeta sd la temperatura y humedad cada X tiempo. Hace falta integrar un reloj para que escriba la hora de la lectura

#include <RTClib.h>               // librería para reloj
  PCF8563 RTC;  // Modelo de reloj rtc
                     
#include <SD.h>

int pinDHT11 = 2;                 // El pin 2 para los datos de la sonda
#include <SimpleDHT.h> 
SimpleDHT11 dht11;

File myFile;

void setup()
{
  Serial.begin(9600);
  Serial.println("Iniciando SD:");
  delay(1000);
  if (!SD.begin(4)) {
    Serial.println("Error, no se pudo inicializar");
    return;
  }
  Serial.println("Inicio Tarjeta MicroSD Correcto");
  delay(1000);
}

void loop()
{
 
  byte T = 0;
  byte HR = 0;
  byte data[40] = {0};
  if (dht11.read(pinDHT11, &T, &HR, data))  

myFile = SD.open("log.txt", FILE_WRITE);//abrimos  el archivo
  
  if (myFile) { 
        
       
        int pinDHT11 = digitalRead(2);
         Serial.println("Escribiendo SD: ");
         
Serial.println("");
//Serial.setCursor(0, 0);
Serial.print("Temp y Hr Actual: ");
  delay(100);
//Serial.setCursor(0, 1);
Serial.print((int)T); Serial.print("*C y ");
Serial.print((int)HR); Serial.println(" % Hr  ");
  delay(2000);
  }
  delay(100);
}
