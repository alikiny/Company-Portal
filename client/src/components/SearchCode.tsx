import React, { useState } from 'react'
import Box from '@mui/material/Box'
import SearchIcon from '@mui/icons-material/Search';
import Input from '@mui/material/Input';
import Button from '@mui/material/Button';
import { Company } from '../types/company';
import axios, { AxiosError } from 'axios';
import { Typography } from '@mui/material';

const SearchCode = () => {
    const [text, setText] = useState("")
    const [data, setData] = useState<Company[]>()
    const [loading, setLoading] = useState(false)
    const [error, setError] = useState("")

    const onSearch = async () => {
        try {
            setLoading(true)
            const result = await axios.get<Company[]>(`https://localhost:5501/api/v1/postal_codes/${text}/companies`)
            setData(result.data)
            setLoading(false)
        } catch (e) {
            const error = e as AxiosError
            setError(error.message)
            setLoading(false)
        }

    }
    return (
        <Box>
            <Box>
                <SearchIcon />
                <Input
                    placeholder='Search by postal code'
                    inputProps={{ 'aria-label': 'search' }}
                    value={text}
                    onChange={(e) => setText(e.target.value)}
                />
                <Button disabled={loading} onClick={onSearch}>Search</Button>
            </Box>
            {!error && !loading && data && (
                <>
                    {data.map(company =>
                        <Box key={company.businessId}>{company.businessId}</Box>
                    )}
                </>
            )}
            {error && <Typography>{error}</Typography>}
            { loading && <Typography>Loading data ...</Typography>}
        </Box>
    )
}

export default SearchCode