// Never do that
function a(x,y,z){
    if (x){
        for (let i = 0; i < y.length; i++){
            if (y[i] > 0){
                z += y[i]*2;
            } else {
                z += y[i];
            }
        }
        if (z > 100){
            return z * 3;
        }
        return z;
    }
    return null;
}

// Better way
/**
 * Processes positive and negative numbers within an array
 * and returns an adjusted total.
 *
 * @param {boolean} isActive - Indicates whether processing is required.
 * @param {number[]} numbers - Array of numbers to be processed.
 * @returns {number|null} Total processed or null if not active.
 */

function processNumbers(isActive, numbers) {
    if (!isActive) {
        return null;
    }

    const total = calculateTotal(numbers);
    return adjustTotal(total);
}

function calculateTotal(numbers) {
    let total = 0;

    for (const num of numbers) {
        total += getAdjustedValue(num);
    }

    return total;
}

function getAdjustedValue(num) {
    if (num > 0) {
        return num * 2;
    }
    return num;
}

function adjustTotal(total) {
    if (total > 10) {
        return total * 3;
    }
    return total;
}
