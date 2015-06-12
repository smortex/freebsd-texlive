# $FreeBSD$

PORTNAME=	listbib
PORTVERSION=	20150412
PORTEPOCH=	1
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Lists contents of BibTeX files.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS SRCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
