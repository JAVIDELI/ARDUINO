/*Puesta en marcha del reloj RTC DS1302, en arduino UNO, que muestra la fecha y la hora,hay que
ponerla a mano de momento, no he podido escribir la linea que coge la fecha y hora del PC
*/

#include <DS1302.h>
#include <SoftwareSerial.h>
//Inicializacion del modulo RTC
DS1302 rtc(2, 3, 5);
Time t;

void setup() {
	// Desprotección contra escritura
	Serial.begin(9600);
	rtc.halt(false);
	rtc.writeProtect(false);
	rtc.setDOW(THURSDAY); //Configurar dia de la semana actual
	//Puesta en hora y fecha
	rtc.setTime(13, 12, 00);
	rtc.setDate(22, 10, 2020);
}

void loop() {
	t = rtc.getTime();
	//Escritura del día de la semana
	Serial.print("Fecha: ");
	if (t.dow == 1) Serial.print("Lunes ");
	if (t.dow == 2) Serial.print("Martes ");
	if (t.dow == 3) Serial.print("Miercoles ");
	if (t.dow == 4) Serial.print("Jueves ");
	if (t.dow == 5) Serial.print("Viernes ");
	if (t.dow == 6) Serial.print("Sabado ");
	if (t.dow == 7) Serial.print("Domingo ");

	Serial.print(t.date, DEC); //día del mes

	//mes
	Serial.print("-");
	Serial.print(t.mon, DEC);

	//Año
	Serial.print("-");
	Serial.print(t.year, DEC);
	Serial.println();
	//horas,minutos,segundos
	Serial.print("Hora: "); 
	Serial.print(t.hour, DEC);
	Serial.print(":");
	Serial.print(t.min, DEC);
	Serial.print(":");
	Serial.print(t.sec, DEC);
	Serial.println();
	Serial.println();
	Serial.println();
	delay(1000);

}