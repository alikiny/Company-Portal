import React, { useEffect } from 'react';
import Box from '@mui/material/Box';

import LoadData from './components/LoadData';
import Header from './components/Header';
import SearchCode from './components/SearchCode';

const App = () => {
  return (
    <Box padding={20}>
      <Header/>
      <LoadData />
      <SearchCode/>
    </Box>
  )
}

export default App
