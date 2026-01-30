## What were the issues with duplicated code?
The duplicated code performed the same actions to create and update the user, repeating the same steps and causing problems with error handling because it would have to be modified in each function.

## How did refactoring improve maintainability?
Distributing responsibilities, such as separating error handling in case of failure and centralizing shared logic for use by multiple functions, reduced the need to repeat validation with each modification and improved maintenance.

---
## Code in JS

```
// WET code

function createUser(user) {
    if (!user) {
        logError("User is null");
        return false;
    }

    if (!user.isActive) {
        logError("User is not active");
        return false;
    }

    console.log("User created");
    return true;
}

function updateUser(user) {
    if (!user) {
        logError("User is null");
        return false;
    }

    if (!user.isActive) {
        logError("User is not active");
        return false;
    }

    console.log("User updated");
    return true;
}

// DRY code
function validateActiveUser(user) {
    if (!user) {
        logError("User is null");
        return false;
    }

    if (!user.isActive) {
        logError("User is not active");
        return false;
    }

    return true;
}

function createUser(user) {
    if (!validateActiveUser(user)) {
        return false;
    }

    console.log("User created");
    return true;
}

function updateUser(user) {
    if (!validateActiveUser(user)) {
        return false;
    }

    console.log("User updated");
    return true;
}

```