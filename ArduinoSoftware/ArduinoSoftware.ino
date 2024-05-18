#include "Keypad.h"
#include <Wire.h>
#include <LiquidCrystal.h>
LiquidCrystal lcd(12, 11, 5, 4, 3, 2);
 
const byte ROWS = 4;
const byte COLS = 3;
char keys[ROWS][COLS] = {{'1', '2', '3'} , {'4', '5', '6'} ,
                         {'7', '8', '9'} , {'*', '0', '#'}};
byte rowPins[ROWS] = {5, 4, 3, 2};
byte colPins[COLS] = {8, 7, 6};
int count=0;
Keypad keypad = Keypad( makeKeymap(keys), rowPins, colPins, ROWS, COLS );
 
void setup()
{
  Serial.begin(9600);
  lcd.begin(16, 4);
  lcd.print("Urun kodunu girin(5 Haneli)=");
  delay(1000);
}
 
void loop()
{
  char key = keypad.getKey();
  if (key != NO_KEY) {
    lcd.print(key);
    Serial.println(key);
    count++;

    if (count == 6) {
      lcd.clear();
      count=0;
    }
  }
}