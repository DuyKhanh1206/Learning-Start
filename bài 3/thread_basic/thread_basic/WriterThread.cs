using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace thread_basic
{
    class WriterThread
    {
        private string _sentence;

        private bool flagtag;
        private int _sleep;
        private string _writerthread;       
        private int _counter;
        private Thread _threadwirite;
        private Stopwatch _stopwatch;

        public string GetWriterThread()
        {
            return _writerthread;
        }
        public WriterThread(int sleep)
        {
            _sleep = sleep;
            _counter = 0;
            return;
        }

        public string Sentence
        {
            get { return _sentence; }
            set
            {
                _sentence = value;
            }
        }

        public bool StartWrite()
            {
                if (true == flagtag)
                    return false;
                _threadwirite = new Thread(WritetThreadMain);
                flagtag = true;
                _threadwirite.Start();

                return true;
            }
        public bool StopWrite()
            {
                if (_threadwirite == null)
                    return true;

                flagtag = false;
                do
                {
                    _threadwirite.Join(100);
                } while (_threadwirite.IsAlive);

                _threadwirite.Abort();
                return true;
            }
        private void WritetThreadMain()
        {            
            while (flagtag)
            {
                _stopwatch = new Stopwatch();
                _stopwatch.Start();
                    if (_sentence[_counter] != '.')
                    {
                        _writerthread += _sentence[_counter];
                    } 
                    else
                    {
                        _writerthread += _sentence[_counter]+ "\n";
                    }                         
                    Thread.Sleep(_sleep);
                if(_counter >= _sentence.Length-1)
                {
                    Thread.Sleep(1000);
                    _counter = 0;
                    _writerthread = "";
                    
                }
                else
                {
                    _counter++;
                }               
            }
            _stopwatch.Stop();
        }

    }
}
