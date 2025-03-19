#include <Wire.h>
#include <LiquidCrystal.h>
#include "Keypad.h"

LiquidCrystal lcd(12, 11, 5, 4, 3, 2);
 
const byte rows = 4;
const byte cols = 3;
char keys[rows][cols] = {{'1', '2', '3'} , {'4', '5', '6'} ,
                         {'7', '8', '9'} , {'*', '0', '#'}};
byte row_pins[rows] = {5, 4, 3, 2};
byte col_pins[cols] = {8, 7, 6};
int count = 0;

Keypad keypad = Keypad(makeKeymap(keys), row_pins, col_pins, rows, cols);
 
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