import React, { useEffect } from 'react';
import axios, { AxiosError } from 'axios';

import { Company, CompanyResponse } from './types/company';
import { BusinessInfoResponse } from './types/businessInfo';

const codes = ["02100", "00140", "00930", "00710", "01730", "00500", "01760", "01690", "00510", "00180"]

const App = () => {
  const onLoadData = async () => {
    try {
      for (let c of codes) {
        const businessInfo = await axios.get<BusinessInfoResponse>(`https://avoindata.prh.fi/bis/v1?totalResults=false&maxResults=10&resultsFrom=0&streetAddressPostCode=${c}`)
        const urls = businessInfo.data.results.map(info => info.detailsUri)
        for (let u of urls) {
          const data = (await axios.get<CompanyResponse>(u)).data.results
          const arr = data[0].registeredEntries?.map(r => r.register)
          if (arr?.some(a => a == 0)) {
            console.log(arr)
          }
          await axios.post("https://localhost:5501/api/v1/companies", data)
        }
        console.log("done")
      }
    } catch (e) {
      console.log(e)
    }
  }

  return (
    <div>
      <button onClick={onLoadData}>Reload data into database</button>
    </div>
  )
}

export default App
