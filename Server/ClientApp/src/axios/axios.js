import axios from "axios"
let connection = axios.create({
    baseURL: 'https://localhost:5001/api/'
});
export default connection;