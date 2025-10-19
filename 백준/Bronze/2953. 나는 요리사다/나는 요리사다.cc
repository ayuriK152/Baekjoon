#include <iostream>
using namespace std;

int main() {
    int num = 0, score = 0;
    for (int i = 0; i < 5; i++) {
        int s[4];
        cin >> s[0] >> s[1] >> s[2] >> s[3];
        if (score < s[0] + s[1] + s[2] + s[3]) {
            num = i + 1;
            score = s[0] + s[1] + s[2] + s[3];
        }
    }
    
    printf("%d %d", num, score);
    
    return 0;
}