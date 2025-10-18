#include <iostream>
using namespace std;

int main() {
    long long a;
    cin >> a;
    if (-32768 <= a && a <= 32767)
        cout << "short";
    else if (-2147483648 <= a && a <= 2147483647)
        cout << "int";
    else
        cout << "long long";
    
    return 0;
}