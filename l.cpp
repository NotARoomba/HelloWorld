#include <iostream>
int main() {
	std::cout << "l";
	system("mcs l.cs");
	system("mono ./l.exe");
	while (true) {}
	return 1;
}