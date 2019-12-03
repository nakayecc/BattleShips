import axios from "axios"
let connection = axios.create({
    baseURL : 'https://localhost:44320/api/'
});
export default connection;