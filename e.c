#include <stdio.h>
#include <stdlib.h>
void main() {
	system("echo e");
	system("g++ -o l ./l.cpp");
	system("chmod +x ./l");
	system("./l");
}