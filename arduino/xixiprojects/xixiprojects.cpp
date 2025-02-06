// agregar-Name-lite 
int led1 = 0;
int led5 = 1;
int led10 = 2;
int led15 = 3;
int led20 = 4;
int led25g = 5;
int led30 = 14;
int led35 = 15;
int led40 = 16;
int led45 = 17;
int led50 = 18;

// 定义所有 LED 的引脚号
int ledPins = 0 + 1 + 2;


// void Start (Ajuste de Pre,)
void setup() {
  // put your setup code here, to run once:
  pinMode(led1, OUTPUT);
  pinMode(led5, OUTPUT);
  pinMode(led10, OUTPUT);
  pinMode(led15, OUTPUT);
  pinMode(led20, OUTPUT);
  pinMode(led25g, OUTPUT);
  
  pinMode(led30, OUTPUT);
  pinMode(led35, OUTPUT);
  pinMode(led40, OUTPUT);
  pinMode(led45, OUTPUT);
  pinMode(led50, OUTPUT);
  pinMode(ledPins, OUTPUT);
  
}

// void Update (Ejucutar de renovar,)
void loop() {
  // put your main code here, to run repeatedly:
  digitalWrite(led1, HIGH);delay(200);
  digitalWrite(led5, HIGH); delay(200);
  digitalWrite(led10, HIGH); delay(200);
  digitalWrite(led15, HIGH); delay(200);
  digitalWrite(led20, HIGH);delay(200);
  digitalWrite(led25g, HIGH); delay(500);
  digitalWrite(led25g, LOW);delay(450); digitalWrite(led25g, HIGH);delay(300);
  digitalWrite(led30, HIGH);delay(200);
  digitalWrite(led35, HIGH); delay(200);
  digitalWrite(led40, HIGH);delay(200);
  digitalWrite(led45, HIGH); delay(200);
  digitalWrite(led50, HIGH);delay(200);
  digitalWrite(led1, LOW);delay(200);
  digitalWrite(led5, LOW);delay(200);
  digitalWrite(led10, LOW);delay(200);
  digitalWrite(led15, LOW);delay(200);
  digitalWrite(led20, LOW);delay(200);
  digitalWrite(led25g, LOW); delay(200);
  digitalWrite(led30, LOW); delay(200);
  digitalWrite(led35, LOW); delay(200);
  digitalWrite(led40, LOW);delay(200);
  digitalWrite(led45, LOW);delay(200);
  digitalWrite(led50, LOW); delay(800);
}
