import React, { useEffect } from 'react';
import axios from 'axios';
import { Response } from './types/businessInfo';
import { Company } from './types/company';

const App = () => {
  useEffect(() => {
    axios.get<Company>("http://avoindata.prh.fi/opendata/bis/v1/3354799-3")
      .then(res => {
        axios.post("https://localhost:5501/api/v1/companies", res.data)
          .then(res => console.log(res.data))
      }).catch(e => console.log(e))
  })
  return (
    <div>App</div>
  )
}

export default App
