#### Why is pushing directly to main problematic?
Generally, the main branch is the production branch, so pushing changes here that might be faulty is problematic because the main branch is usually kept as a stable branch, from which other branches are taken to be modified and then those changes are brought back to the main branch.

#### How do branches help with code review?
They allow you to find errors that were accidentally pushed from other branches to the main branch, or that worked in the secondary branch but not in the main branch. This helps in testing without having to lose or undo all the changes made. They also serve as a kind of history.

#### What happens if two people edit the same file on different branches?
Nothing, they are working on two completely different files. The only problem would be when deploying the changes to the main branch, as they would overlap.