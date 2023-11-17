#include <string>
#include <vector>

using namespace std;

vector<int> solution(int brown, int yellow) {
    vector<int> answer;
    int x = 1;
    int y = yellow;
    while (true) {
        if (brown == (x + y) * 2 + 4) {
            answer.push_back((x > y ? x : y) + 2);
            answer.push_back((x > y ? y : x) + 2);
            break;
        }
        while (true) {
            x++;
            if(yellow % x == 0) {
                y = yellow / x;
                break;
            }
        }
    }
    return answer;
}