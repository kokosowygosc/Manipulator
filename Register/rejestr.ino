
#include <Servo.h>
#include <ctype.h>
#define przelacznik 7
Servo serwomechanizm1;  //Obiekt serwomechanizm 1
Servo serwomechanizm2;  //Obiekt serwomechanizm 2
Servo serwomechanizm3;  //Obiekt serwomechanizm 3
Servo serwomechanizm4;  //Obiekt serwomechanizm 4
Servo serwomechanizm5;  //Obiekt serwomechanizm 5
Servo serwomechanizm6;  //Obiekt serwomechanizm 6
int serwo1 = 90;         //Wartosc serwomechanizmu 1
int serwo2 = 40;         //Wartosc serwomechanizmu 2
int serwo3 = 170;         //Wartosc serwomechanizmu 3
int serwo4 = 40;         //Wartosc serwomechanizmu 4
int serwo5 = 0;         //Wartosc serwomechanizmu 5
int serwo6 = 0;         //Wartosc serwomechanizmu 6

void setup() {
 Serial.begin(9600);
 pinMode(przelacznik, INPUT_PULLUP);
 serwomechanizm1.attach(9);  //Serwomechanizm 1 podłączony do pinu 9
 serwomechanizm2.attach(10); //Serwomechanizm 2 podłączony do pinu 10
 serwomechanizm3.attach(6);  //Serwomechanizm 3 podłączony do pinu 6
 serwomechanizm4.attach(5);  //Serwomechanizm 4 podłączony do pinu 5
 serwomechanizm5.attach(8); //Serwomechanizm 5 podłączony do pinu 3
 serwomechanizm6.attach(4); //Serwomechanizm 6 podłączony do pinu 4

}

void loop() {
  if(digitalRead(przelacznik)==LOW) //sterowanie ramieniem widmowym
  {
      serwo1=analogRead(A5);
      serwo2=analogRead(A5);
      serwo3=analogRead(A5);
      serwo4=analogRead(A5);
      serwo5=analogRead(A5);
      serwo6=analogRead(A5);
      
      serwo1=map(serwo1,0,1010,1,178);
      serwomechanizm1.write(serwo1);
      delay(2);
      serwo2=map(serwo2,0,1010,1,178);
      serwomechanizm2.write(serwo2); 
      delay(2); 
      serwo3=map(serwo3,0,1010,1,178);
      serwomechanizm3.write(serwo3); 
      delay(2);
      serwo4=map(serwo4,0,1010,1,178);
      serwomechanizm4.write(serwo4); 
      delay(2);
      serwo5=map(serwo5,0,1010,1,178);
      serwomechanizm5.write(serwo5); 
      delay(2);
      serwo6=map(serwo6,0,1010,1,178);
      serwomechanizm6.write(serwo6); 
      delay(2);     
        Serial.print("Serwo1:"); Serial.print(serwo1); Serial.println(" ");
        Serial.print("Serwo2:"); Serial.print(serwo2); Serial.println(" ");
        Serial.print("Serwo3:"); Serial.print(serwo3); Serial.println(" ");
        Serial.print("Serwo4:"); Serial.print(serwo4); Serial.println(" "); 
        Serial.print("Serwo5:"); Serial.print(serwo5); Serial.println(" ");
        Serial.print("Serwo6:"); Serial.print(serwo6); Serial.println(" ");
  }
  else //sterowanie programem
  {
    serwomechanizm1.write(serwo1);
    serwomechanizm2.write(serwo2);
    serwomechanizm3.write(serwo3);
    serwomechanizm4.write(serwo4);
    serwomechanizm5.write(serwo5);
    serwomechanizm6.write(serwo6);
    if(Serial.available()!=0)
    {
      String wartoscstring = Serial.readStringUntil(' '); // S1=45 
      switch(wartoscstring.charAt(1))
      {
        case '1':
          serwo1=wartoscstring.substring(3,6).toInt();
          serwomechanizm1.write(serwo1);
          break;
        case '2':
          serwo2=wartoscstring.substring(3,6).toInt();
          serwomechanizm2.write(serwo2);
          break;
        case '3':
          serwo3=wartoscstring.substring(3,6).toInt();
          serwomechanizm3.write(serwo3);
          break;
        case '4':
          serwo4=wartoscstring.substring(3,6).toInt();
          serwomechanizm4.write(serwo4);
          break;
        case '5':
          serwo5=wartoscstring.substring(3,6).toInt();
          serwomechanizm5.write(serwo5);
          break;
        case '6':
          serwo6=wartoscstring.substring(3,6).toInt();
          serwomechanizm6.write(serwo6);
          break;
        default: 
          break;
      }
     } 
  }
}
