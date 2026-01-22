// Hard to read
function div(a, b) {
    return (a === null || b === null) ? null : a / b;
}

function d(a, b) {
    if (a !== null) {
        if (b !== null) {
            return a / b;
        }
    }
}

// Easier to read
function divide(a, b) {
    if (a === null) throw new Error("First argument is null");
    if (b === null) throw new Error("Second argument is null");
    return a / b;
}

// Not with type checking
function saferdivide(a, b) {
    // Check for null or undefined, but not if i send "ABC"
    if (a == null) {
        throw new Error("First argument is null or undefined");
    }

    if (b == null) {
        throw new Error("Second argument is null or undefined");
    }

    return a / b;
}

// Even better with type checking
function safedivide(a, b) {
    if (typeof a !== "number" || typeof b !== "number") {
        throw new Error("Both parameters must be numbers");
    }

    if (b === 0) {
        throw new Error("Cannot divide by zero");
    }

    return a / b;
}

// Best with type and value checking
function BestsafeDivide(a, b) {
    if (!Number.isFinite(a) || !Number.isFinite(b)) {
        throw new TypeError("Parameters must be finite numbers");
    }

    if (b === 0) {
        throw new RangeError("Division by zero is not allowed");
    }

    return a / b;
}
