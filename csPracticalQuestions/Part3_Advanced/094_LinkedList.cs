using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    // List<T>나 LinkedList<T> 클래스는 C#에서 컬렉션으로 제공하고 있다.
    // 하지만 이러한 자료구조를 직접 만드는 것이 프로그램 공부에 매우 도움이 된다.
    // 이번에는 연결리스트 LinkedList를 직접 구현해 보겠습니다. LinkedList 클래스를
    // 별도의 파일에 만들겠다. 이렇게 하는 이유는 LinkedList를 만들어 두고 다른 프로그램에서도
    // 쓸 수 있기 때문입니다. 보통 클래스는 클래스 이름과 같은 cs 파일에 만듭니다.
    
    // 클래스 파일에 별도로 만들 때는 솔루션 탐색기의 프로젝트 이름 위에서 마우스 오른쪽 버튼을
    // 누르고 나타나는 팝업 메뉴에서 "추가"-"클래스"를 선택하고 클래스 이름을 입력하면 된다.
    // 여기서는 클래스 이름과 같은 LinkedList.cs라는 파일을 추가한다.
    // LinkedList.cs 파일에는 Node 클래스와 LinkedList 클래스의 두개의 클래스를 만듭니다.
    // Node 클래스는 리스트의 각 노드를 표현하는 클래스이며 아래 표와 같이 Node 타입의
    // head 필드와 7개의 메소드로 구성된다. 연결리스트에 대한 자세한 설명은 생략

    // [Node 클래스의 필드와 메소드]
    //  int date : 노드에 자장되는 값입니다.
    //  Node next : 리스트에서 다음에 연결되는 노드입니다.
    //  Node(int data) : Node 클래스의 생성자입니다. data를 저장하는 Node를 생성한다.

    // [LinkedList 클래스의 필드와 메소드]
    // Node head : 리스트의 첫 번째 노드입니다.
    // void InsertFront(int data) : 리스트의 맨 앞에 data를 추가합니다.
    class Node
    {
        internal int data;
        internal Node next;
        public Node(int data)  // 생성자
        {
            this.data = data;
            next = null;
        }
    }

    class LinkedList
    {
        Node head;

        internal void InsertFront(int data)
        {
            Node node = new Node(data);
            node.next = head;
            head = node;
        }
        internal void InsertLast(int data)
        {
            Node node = new Node(data);
            if (head == null)
            {
                head = node;
                return;
            }
            Node lastNode = GetLastNode();
            lastNode.next = node;
        }

        internal Node GetLastNode()
        {
            Node temp = head;
            while(temp.next != null)
            {
                temp = temp.next;
            }
            return temp;
        }

        // prev 뒤에 data를 갖는 노드 삽입하기
        internal void InsertAfter(int prev, int data)
        {
            Node prevNode = null;

            // find prev
            for (Node temp = head; temp != null; temp = temp.next)
                if (temp.data == prev)
                    prevNode = temp;

            if (prevNode == null)
            {
                Console.WriteLine("{0} data is not in the list");
                return;
            }
            Node node = new Node(data);
            node.next = prevNode.next;
            prevNode.next = node;
        }

        // key값을 저장하고 있는 노드 삭제하기
        internal void DeleteNode(int key)
        {
            Node temp = head;
            Node prev = null;
            if (temp != null && temp.data == key) // head가 찾는 값이면
            {
                head = temp.next;
                return;
            }
            while (temp != null && temp.data != key)
            {
                prev = temp;
                temp = temp.next;
            }
            if (temp == null) // 끝까지 찾는 값이 없으면
            {
                return;
            }
            prev.next = temp.next;
        }

        internal void Reverse()
        {
            Node prev = null;
            Node current = head;
            Node temp = null;
            while (current != null)
            {
                temp = current.next;
                current.next = prev;
                prev = current;
                current = temp;
            }
            head = prev;
        }

        internal void Print()
        {
            for (Node node = head; node != null; node = node.next)
                Console.Write(node.data + " -> ");
            Console.WriteLine();
        }
    }
}