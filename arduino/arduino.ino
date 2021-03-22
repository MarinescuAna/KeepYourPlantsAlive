int msensor = A0; // moisture sensor is connected with the analog pin A0 of the Arduino
int msvalue = 0; // moisture sensor value 

void setup() {
  Serial.begin(9600);
  pinMode(msensor, INPUT);  
}
 
void loop() {
  msvalue = analogRead(msensor);
  Serial.println(msvalue);
  delay(1000);      
}
