function addToCart(productId) {
    fetch('/Men/AddToCart', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({ productId: productId })
    }).then(response => {
        if (response.ok) {
            alert('Product added to cart!');
        }
    });
}

function toggleWishlist(productId) {
    fetch('/Men/AddToWishlist', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({ productId: productId })
    }).then(response => {
        if (response.ok) {
            const icon = document.getElementById(`wishlist-icon-${productId}`);
            if (icon.innerHTML === '&#x2661;') {
                icon.innerHTML = '&#x2665;';
                icon.style.color = 'red';
            } else {
                icon.innerHTML = '&#x2661;';
                icon.style.color = 'black';
            }
            alert('Product added to wishlist!');
        }
    });
}