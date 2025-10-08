#include <bits/stdc++.h>
using namespace std;

int main() {
    int n, height = 0, total = 1;
    cin >> n;
    for (int i = 1; ; i++) {
        if (n < total)
            break;
        n -= total;
        total += 4 * i;
        height += 1;
    }
    cout << height;
    
    return 0;
}