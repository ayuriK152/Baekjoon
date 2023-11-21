#include <string>
#include <vector>
#include <algorithm>

using namespace std;

vector<int> solution(int N, vector<int> stages) {
    vector<int> answer;
    sort(stages.begin(), stages.end());
    vector<pair<int, float>> diff;
    for (int i = 0; i < N; i++) {
        float a = stages.size();
        if (a == 0) {
            diff.push_back({i + 1, 0});
            continue;
        }
        float b = 0;
        for (int j = 0; j < stages.size(); j++) {
            if (stages[j] == i + 1) {
                b++;
                j--;
                stages.erase(stages.begin());
            }
            else
                break;
        }
        diff.push_back({i + 1, b/a});
    }
    sort(diff.begin(), diff.end(), [](pair<int, float> a, pair<int, float> b){ if (a.second == b.second) return a.first < b.first; return a.second > b.second; });
    for (int i = 0; i < N; i++) {
        answer.push_back(diff[i].first);
    }
    return answer;
}