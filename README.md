# Manipulator
Hobby time: Software to control manipulator 

Notice: project has been not finished yet. There is plan to also add control by phantom mini manipulator made with potentiometer. Big manipulator will copy its moves.

In my free time I allowed myself to build a fully working manipulator from scratch. 

The controller is Atmega 328 with bootloader from arduino. There are 6 servos with space for more. The skeleton was print on my 3d printer Anet. 

Control_panel has been write in C# and it is complete software to control manipulator from computer, also to check its condition. 
Register includes program writen in arduino to process data from computer. 

There is also lib libusb_0.1.12.1 for USB TO SERIAL/TTL ADAPTER to read Tx/Rx pins from atmega.
3d project was taken from: 

https://www.thingiverse.com/thing:2433 

with my few changes. 


There are some pictures: 
https://github.com/kokosowygosc/Manipulator/blob/master/Pictures/28945093_1671744989560721_1813475598_o.jpg
https://github.com/kokosowygosc/Manipulator/blob/master/Pictures/28945616_1671745089560711_1318698905_o.jpg
https://github.com/kokosowygosc/Manipulator/blob/master/Pictures/28946085_1671745032894050_862066334_o.jpg

Hope you like it!
