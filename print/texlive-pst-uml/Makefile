# $FreeBSD$

PORTNAME=	pst-uml
PORTVERSION=	20160414
PORTEPOCH=	1
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	UML diagrams with PSTricks

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/tex/generic/multido/multido.tex:${PORTSDIR}/print/texlive-multido

OPTIONS_DEFINE=	DOCS SRCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
