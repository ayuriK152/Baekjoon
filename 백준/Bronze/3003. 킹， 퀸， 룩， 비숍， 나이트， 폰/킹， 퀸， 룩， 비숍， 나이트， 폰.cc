#include <iostream>
using namespace std;

int main() {
    int arr[6] = { 1, 1, 2, 2, 2, 8 };
    for (int i = 0; i < 6; i++) {
        int n;
        cin >> n;
        arr[i] -= n;
    }
    printf("%d %d %d %d %d %d", arr[0], arr[1], arr[2], arr[3], arr[4], arr[5]);
    
    return 0;
}