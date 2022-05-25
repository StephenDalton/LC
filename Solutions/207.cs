//https://leetcode.com/problems/course-schedule/discuss/58524/Java-DFS-and-BFS-solution/60015
public class Solution {
    public bool CanFinish(int numCourses, int[][] prerequisites) {
        bool[] canFinish = new bool[numCourses];
        bool[] visited = new bool[numCourses];
        
        for (int i=0; i<numCourses; i++)
        {
            if (!CanFinishCourse(i, prerequisites, canFinish, visited))
                return false;
        }
        
        return true;
    }
    
    private bool CanFinishCourse(int course, int[][] prereqs, bool[] canFinish, bool[] visited) {
        if (canFinish[course])
            return true;
        if (visited[course])
            return false;
        
        visited[course] = true;
        
        for (int i=0; i<prereqs.Length; i++)
        {
            if (prereqs[i][0] == course && !CanFinishCourse(prereqs[i][1], prereqs, canFinish, visited))
                return false;
        }
        
        visited[course] = false;
        canFinish[course] = true;
        
        return true;
    }
}
