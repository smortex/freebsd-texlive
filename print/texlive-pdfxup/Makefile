# $FreeBSD$

PORTNAME=	pdfxup
PORTVERSION=	20160423
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Create n-up PDF pages with minimal margins

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
