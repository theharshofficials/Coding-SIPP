.container {
  padding: 20px;
  margin: 20px;
  border: 1px solid black;
  border-radius: 10px;
  font-family: Arial, sans-serif;
  font-size: 20px;
  background-color: #f0f0f0;
}

h2 {
  margin-bottom: 10px;
}

.sort-select, .category-select, .search-input {
  padding: 8px;
  width: 300px;
  font-size: 16px;
  margin-bottom: 20px;
  border-radius: 5px;
  border: 1px solid #ccc;
}

.sort-select {
  margin-right: 10px;
}

.product-list {
  list-style-type: none;
  padding-left: 0;
  display: grid;
  grid-template-columns: repeat(auto-fill, minmax(220px, 1fr));
  gap: 15px;
}

.product-item {
  padding: 10px;
  background-color: white;
  border-radius: 5px;
  box-shadow: 0 0 5px rgba(0,0,0,0.1);
  display: flex;
  flex-direction: column;
  justify-content: center;
}

.product-title {
  font-weight: bold;
}

.product-price,
.product-rating {
  margin-top: 4px;
}