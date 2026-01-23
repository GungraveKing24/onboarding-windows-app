// Not understandable

function f(a, b) {
    let x = 0;

    for (let i = 0; i < a.length; i++) {
        x += a[i].p * a[i].q;
    }

    if (b) {
        x = x - x * b;
    }

    return x;
}

// Understandable

function calculateOrderTotal(items, discountRate) {
    let totalPrice = 0;

    for (const item of items) {
        totalPrice += item.price * item.quantity;
    }

    if (discountRate) {
        totalPrice -= totalPrice * discountRate;
    }

    return totalPrice;
}
