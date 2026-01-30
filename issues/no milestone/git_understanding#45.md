#### What does `git bisect` do?
It helps you find exactly which commit introduced a bug, using a binary search that's faster than checking each commit individually.

#### When would you use it in a real-world debugging situation?
When a bug appears and it's unclear which commit introduced it, especially in projects with many commits or multiple developers.

#### How does it compare to manually reviewing commits?
Git bisect is faster and more efficient. While manual review is linear, bisect reduces the number of tests exponentially.

---
## Evidence:
##### Firts git status to see that is nothing to update
![alt text](../../images/git_understanding-45.png)

##### Adding a file without errors
![alt text](../../images/git_understanding-45-1.png)

##### Mark it as correct
![alt text](../../images/git_understanding-45-2.png)

##### Here you can see the commit history to search by its binary
![alt text](../../images/git_understanding-45-3.png)

##### The final result of bisect
![alt text](../../images/git_understanding-45-4.png)