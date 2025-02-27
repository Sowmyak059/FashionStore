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

document.addEventListener('DOMContentLoaded', function () {
    const reviewForm = document.getElementById('review-form');
    if (reviewForm) {
        reviewForm.addEventListener('submit', function (event) {
            event.preventDefault();
            submitReview();
        });
    }
});

function loadReviews(productId) {
    fetch(`/Reviews/GetReviews?productId=${productId}`)
        .then(response => response.json())
        .then(reviews => {
            const container = document.getElementById('reviews-container');
            container.innerHTML = '';
            reviews.forEach(review => {
                const reviewElement = document.createElement('div');
                reviewElement.classList.add('review');
                reviewElement.innerHTML = `
                    <p><strong>${review.reviewerName}</strong> (${new Date(review.reviewDate).toLocaleDateString()}):</p>
                    <p>${review.comment}</p>
                    <p>Rating: ${review.rating}/5</p>
                `;
                container.appendChild(reviewElement);
            });
        });
}

function submitReview() {
    const productId = parseInt(document.getElementById('productId').value, 10);
    const reviewerName = document.getElementById('reviewerName').value;
    const comment = document.getElementById('comment').value;
    const rating = parseInt(document.getElementById('rating').value, 10);

    fetch('/Reviews/Create', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({
            ProductID: productId,
            ReviewerName: reviewerName,
            Comment: comment,
            Rating: rating
        })
    }).then(response => {
        if (response.ok) {
            loadReviews(productId);
            document.getElementById('review-form').reset();
        } else {
            alert('Failed to submit review');
        }
    });
}

function getProductIdFromUrl() {
    const urlParams = new URLSearchParams(window.location.search);
    const productId = urlParams.get('productId');
    return productId ? parseInt(productId, 10) : null;
}

document.addEventListener('DOMContentLoaded', function () {
    const productId = getProductIdFromUrl();
    if (productId) {
        loadReviews(productId);
    }
});