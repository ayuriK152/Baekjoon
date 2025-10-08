#include <iostream>
#include <cstring>
using namespace std;

int main() {
	string a, b;
	cin >> a >> b;
	if (a.size() < b.size())
		cout << "no";
	else
		cout << "go";

	return 0;
}