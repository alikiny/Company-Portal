import React, { useState } from 'react'
import axios, { AxiosError } from 'axios'
import { Box, Button, Skeleton, Typography } from '@mui/material'

import { BusinessInfoResponse } from '../types/businessInfo'
import { CompanyResponse } from '../types/company'

const codes = ["02100", "00140", "00930", "00710", "01730", "00500", "01760", "01690", "00510", "00180"]

const LoadData = () => {
    const [error, setError] = useState("")
    const [loading, setLoading] = useState(false)
    const [loaded, setLoaded] = useState(false)

    const onLoadData = async () => {
        try {
            setLoading(true)
            for (let c of codes) {
                const businessInfo = await axios.get<BusinessInfoResponse>(`https://avoindata.prh.fi/bis/v1?totalResults=false&maxResults=10&resultsFrom=0&streetAddressPostCode=${c}`)
                const urls = businessInfo.data.results.map(info => info.detailsUri)
                for (let u of urls) {
                    const data = (await axios.get<CompanyResponse>(u)).data.results
                    await axios.post("https://localhost:5501/api/v1/companies", data)
                }
            }
            setLoading(false)
            setLoaded(true)
        } catch (e) {
            const error = e as AxiosError
            setLoading(false)
            setError(error.message)
        }
    }



    return (
        <Box>
            <Button onClick={onLoadData}>Reload data into database</Button>
            {error && <Typography>{error}</Typography>}
            {loading && (
                <>
                    <Typography>Data is loading, please wait ...</Typography>
                    <Skeleton animation="wave"></Skeleton>
                </>
            )}
            {!error && !loading && loaded && <Typography>Data has been loaded successfully</Typography>}
        </Box>
    )
}

export default LoadData