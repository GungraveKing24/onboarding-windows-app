// Over complex nested conditionals
function processUser(user) {
    if (user !== null) {
        if (user.isActive === true) {
            if (user.age !== null && user.age >= 18) {
                console.log("User is valid");
                return true;
            } else {
                console.log("User is underage");
                return false;
            }
        } else {
            console.log("User is not active");
            return false;
        }
    } else {
        console.log("User is null");
        return false;
    }
}

// Refactored code with early returns and helper functions
function processUser(user) {
    if (!user) {
        logError("User is null");
        return false;
    }

    if (!user.isActive) {
        logError("User is not active");
        return false;
    }

    if (!isAdult(user)) {
        logError("User is underage");
        return false;
    }

    console.log("User is valid");
    return true;
}

function isAdult(user) {
    return typeof user.age === "number" && user.age >= 18;
}

function logError(message) {
    console.log(message);
}