/*
 * Created by SharpDevelop.
 * 
 * To change this template use Tools | Options | Coding | Edit Standard Headers.
 */
using System;

namespace AutomaticControl1
{
	class Program
	{
		public static void Main(string[] args)
		{
			bool imputControl; // пропуск на въезд автомобиля получен
			bool outputControl; // пропуск на выезд автомобиля получен
			bool doorInControl; // пропуск на вход посетителя получен
			bool doorOutControl; // пропуск на выход посетителя получен 
			bool inNoEmpty; // под впускным шлакбаумом находится посторонний объект
			bool outNoEmpty; // под выпускным шлакбаумом находится посторонний объект
			bool gateInOpen; // команда открыть впускной шлакбаум где true – открыть, а false – закрыть. 
			bool gateOutOpen; // команда открыть выпускной шлакбаум где true – открыть, а false – закрыть. 
			bool doorOpen; // команда открыть двери для посетителей где true – открыть, а false – закрыть. 
			int gateControl; // состояние пропускной системы
			
			
			
			
			switch ( gateControl ) 
				{	
				case 0 :
				gateInOpen = false;
				gateOutOpen = false;
				doorOpen = false; 
				if ( imputControl == true and outputControl == false and doorInControl == false and doorOutControl == false ) 
				{
				gateControl = 1 ;
				}
				else if ( imputControl == true and outputControl == true and doorInControl == false and doorOutControl == false ) 
				{
				gateControl = 2 ;
				}
				else if ( imputControl == true and outputControl == true and doorInControl == true and doorOutControl == true ) 
				{
				gateControl = 3 ;
				}
				else if ( imputControl == false and outputControl == true and doorInControl == false and doorOutControl == false ) 
				{
				gateControl = 4 ;
				}
				else if ( imputControl == false and outputControl == false and doorInControl == true and doorOutControl == true ) 
				{
				gateControl = 5 ;
				}
				else if ( imputControl == false and outputControl == true and doorInControl == true and doorOutControl == true ) 
				{
				gateControl = 6 ;
				}
				break;
				case 1:
				gateInOpen = true;
				gateOutOpen = false;
				doorOpen = false;
				do 
				{
				gateInOpen = true;
				}
				while ( inNoEmpty == false )
				if ( inNoEmpty == true )
				{
				gateInOpen = false;
				}
				if ( imputControl == false and outputControl == false and doorInControl == false and doorOutControl == false ) 
				{
				gateControl = 0 ;
				}
				else if ( imputControl == true and outputControl == true and doorInControl == false and doorOutControl == false ) 
				{
				gateControl = 2 ;
				}
				else if ( imputControl == true and outputControl == true and doorInControl == true and doorOutControl == true ) 
				{
				gateControl = 3 ;
				}
				else if ( imputControl == false and outputControl == true and doorInControl == false and doorOutControl == false ) 
				{
				gateControl = 4 ;
				}
				else if ( imputControl == false and outputControl == false and doorInControl == true and doorOutControl == true ) 
				{
				gateControl = 5 ;
				}
				else if ( imputControl == false and outputControl == true and doorInControl == true and doorOutControl == true ) 
				{
				gateControl = 6 ;
				}
				break;
				case 2:
				gateInOpen = true; 
				gateOutOpen = true; 
				doorOpen = false; 
				do 
				{
				gateInOpen = true;
				}
				while ( inNoEmpty == false )
				if ( inNoEmpty == true )
				{
				gateInOpen = false;
				}
				do 
				{
				gateOutOpen = true;
				}
				while ( outNoEmpty == false )
				if ( outNoEmpty == true )
				{
				gateOutOpen = false;
				}
				if ( imputControl == true and outputControl == false and doorInControl == false and doorOutControl == false ) 
				{
				gateControl = 1 ;
				}
				else if ( imputControl == false and outputControl == false and doorInControl == false and doorOutControl == false ) 
				{
				gateControl = 0 ;
				}
				else if ( imputControl == true and outputControl == true and doorInControl == true and doorOutControl == true ) 
				{
				gateControl = 3 ;
				}
				else if ( imputControl == false and outputControl == true and doorInControl == false and doorOutControl == false ) 
				{
				gateControl = 4 ;
				}
				else if ( imputControl == false and outputControl == false and doorInControl == true and doorOutControl == true ) 
				{
				gateControl = 5 ;
				}
				else if ( imputControl == false and outputControl == true and doorInControl == true and doorOutControl == true ) 
				{
				gateControl = 6 ;
				}
				break;
				case 3:
				gateInOpen = true;
				gateOutOpen = true;
				doorOpen = true;
				do 
				{
				gateInOpen = true;
				}
				while ( inNoEmpty == false )
				if ( inNoEmpty == true )
				{
				gateInOpen = false;
				}
				do 
				{
				gateOutOpen = true;
				}
				while ( outNoEmpty == false )
				if ( outNoEmpty == true )
				{
				gateOutOpen = false;
				}
				if ( imputControl == true and outputControl == false and doorInControl == false and doorOutControl == false ) 
				{
				gateControl = 1 ;
				}
				else if ( imputControl == true and outputControl == true and doorInControl == false and doorOutControl == false ) 
				{
				gateControl = 2 ;
				}
				else if ( imputControl == false and outputControl == false and doorInControl == false and doorOutControl == false ) 
				{
				gateControl = 0 ;
				}
				else if ( imputControl == false and outputControl == true and doorInControl == false and doorOutControl == false ) 
				{
				gateControl = 4 ;
				}
				else if ( imputControl == false and outputControl == false and doorInControl == true and doorOutControl == true ) 
				{
				gateControl = 5 ;
				}
				else if ( imputControl == false and outputControl == true and doorInControl == true and doorOutControl == true ) 
				{
				gateControl = 6 ;
				}
				break;
				case 4:
				gateInOpen = false; 
				gateOutOpen = true; 
				doorOpen = false; 
				do 
				{
				gateOutOpen = true;
				}
				while ( outNoEmpty == false )
				if ( outNoEmpty == true )
				{
				gateOutOpen = false;
				}
				if ( imputControl == true and outputControl == false and doorInControl == false and doorOutControl == false ) 
				{
				gateControl = 1 ;
				}
				else if ( imputControl == true and outputControl == true and doorInControl == false and doorOutControl == false ) 
				{
				gateControl = 2 ;
				}
				else if ( imputControl == true and outputControl == true and doorInControl == true and doorOutControl == true ) 
				{
				gateControl = 3 ;
				}
				else if ( imputControl == false and outputControl == false and doorInControl == false and doorOutControl == false ) 
				{
				gateControl = 0 ;
				}
				else if ( imputControl == false and outputControl == false and doorInControl == true and doorOutControl == true ) 
				{
				gateControl = 5 ;
				}
				else if ( imputControl == false and outputControl == true and doorInControl == true and doorOutControl == true ) 
				{
				gateControl = 6 ;
				}
				break;
				case 5:
				gateInOpen = false; 
				gateOutOpen = false; 
				doorOpen = true; 
				if ( imputControl == true and outputControl == false and doorInControl == false and doorOutControl == false ) 
				{
				gateControl = 1 ;
				}
				else if ( imputControl == true and outputControl == true and doorInControl == false and doorOutControl == false ) 
				{
				gateControl = 2 ;
				}
				else if ( imputControl == true and outputControl == true and doorInControl == true and doorOutControl == true ) 
				{
				gateControl = 3 ;
				}
				else if ( imputControl == false and outputControl == true and doorInControl == false and doorOutControl == false ) 
				{
				gateControl = 4 ;
				}
				else if ( imputControl == false and outputControl == false and doorInControl == false and doorOutControl == false ) 
				{
				gateControl = 0 ;
				}
				else if ( imputControl == false and outputControl == true and doorInControl == true and doorOutControl == true ) 
				{
				gateControl = 6 ;
				}
				break;
				case 6:
				gateInOpen = false; 
				gateOutOpen = true; 
				doorOpen = true; 
				do 
				{
				gateOutOpen = true;
				}
				while ( outNoEmpty == false )
				if ( outNoEmpty == true )
				{
				gateOutOpen = false;
				}
				if ( imputControl == true and outputControl == false and doorInControl == false and doorOutControl == false ) 
				{
				gateControl = 1 ;
				}
				else if ( imputControl == true and outputControl == true and doorInControl == false and doorOutControl == false ) 
				{
				gateControl = 2 ;
				}
				else if ( imputControl == true and outputControl == true and doorInControl == true and doorOutControl == true ) 
				{
				gateControl = 3 ;
				}
				else if ( imputControl == false and outputControl == true and doorInControl == false and doorOutControl == false ) 
				{
				gateControl = 4 ;
				}
				else if ( imputControl == false and outputControl == false and doorInControl == true and doorOutControl == true ) 
				{
				gateControl = 5 ;
				}
				else if ( imputControl == false and outputControl == false and doorInControl == false and doorOutControl == false ) 
				{
				gateControl = 0 ;
				}
				break;
				}
			/*
			  * 
			  * 
			  * 
			  * Данный код педоставлен в ознакомительных целях, для конкетного внедрения на определенной системе удет нужна доработка под потребноси этой системы.
			  * This code is provided in acquittal purposes, for a particular implementation on a certain system, refinement will be needed for the need of this system.
			  * 
			  * 
			  * 
			  * */
		}
	}
}