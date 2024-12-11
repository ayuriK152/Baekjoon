#include <string>
#include <vector>

using namespace std;

int solution(int n) {
    int answer = 1;
    
    for (int i = 1; i <= n / 2; i++) {
        if ((n - i) % (2 * i) == 0 && (n - i) / (2 * i) <= i - 1)
            answer++;
        else if (n % (2 * i + 1) == 0 && n / (2 * i + 1) <= i)
            answer++;
    }
    
    return answer;
}