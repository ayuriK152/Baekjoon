#include <string>
#include <vector>

using namespace std;

vector<string> solution(int n, vector<int> arr1, vector<int> arr2) {
    vector<string> answer;
    for (int i = 0; i < n; i++) {
        string temp = "";
        int current = 1 << n - 1;
        for (int j = 0; j < n; j++) {
            if ((arr1[i] & current) == current || (arr2[i] & current) == current)
                temp.append("#");
            else
                temp.append(" ");
            current = current >> 1;
        }
        answer.push_back(temp);
    }
    return answer;
}