#include <PubSubClient.h>
#include <Ethernet.h>
  #include <SPI.h>


IPAddress server(192, 168, 1, 53);
EthernetClient ethClient;
PubSubClient client(ethClient);
void setup() {


client.setServer(server, port);
client.setCallback(callback);

}

void loop() {
  // put your main code here, to run repeatedly:




if (!client.connected()){
    client.connect();
}


client.loop();



}
