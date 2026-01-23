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


