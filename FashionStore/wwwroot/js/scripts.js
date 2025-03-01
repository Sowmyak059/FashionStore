
function addToCart(productId) {
    fetch('/Cart/AddToCart', {
        method: 'POST',
        headers: {
            'Content-Type': 'application/json'
        },
        body: JSON.stringify({ productId: productId })
    }).then(response => {
        if (response.ok) {
            alert('Product added to cart!');
        } else {
            response.text().then(text => {
                alert('Please Login to avail this feature');
            });
        }
    }).catch(error => {
        console.error('Error:', error);
        alert('An error occurred while adding the product to the cart.');
    });
}
function deleteFromCart(cartItemId) {
    fetch(`/Cart/DeleteFromCart/${cartItemId}`, {
        method: 'DELETE'
    }).then(response => {
        if (response.ok) {
            alert('Product removed from cart!');
            location.reload();
        }
    });
}

function deleteFromWishlist(wishlistItemId) {
    fetch(`/Cart/DeleteFromWishlist/${wishlistItemId}`, {
        method: 'DELETE'
    }).then(response => {
        if (response.ok) {
            alert('Product removed from wishlist!');
            location.reload();
        }
    });
}

function toggleWishlist(productId) {
    fetch('/Cart/AddToWishlist', {
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
        } else {
            response.text().then(text => {
                alert('Please Login to avail this feature');
            });
        }
    }).catch(error => {
        console.error('Error:', error);
        alert('An error occurred while adding the product to the cart.');
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
                    <p>
                        Rating: 
                        ${[...Array(5)].map((_, i) => i < review.rating ? '<span class="star gold">&#9733;</span>' : '<span class="star">&#9734;</span>').join('')}
                    </p>
                    <hr />
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
            console.log('Review submitted successfully');
            loadReviews(productId);
            document.getElementById('review-form').reset();
        } else {
            response.json().then(data => {
                console.error('Failed to submit review:', data);
                alert('Failed to submit review');
            });
        }
    }).catch(error => {
        console.error('Error submitting review:', error);
        alert('Failed to submit review');
    });
}