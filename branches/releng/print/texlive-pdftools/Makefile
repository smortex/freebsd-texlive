# $FreeBSD$

PORTNAME=	pdftools
PORTVERSION=	20140522
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	PDF-related utilities, including PostScript-to-PDF conversion

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
