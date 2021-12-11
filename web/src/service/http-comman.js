import axios from 'axios'

export default axios.create({
    baseURL: "https://localhost:5000",
    headers: {
        "Content-type": "application/json",
        "Access-Control-Allow-Origin": "*",
        // header := w.Header()
        "Access-Control-Allow-Methods": "DELETE, POST, GET, OPTIONS",
       "Access-Control-Allow-Headers": "Content-Type, Access-Control-Allow-Headers, Authorization, X-Requested-With",
    }
})