# $FreeBSD$

PORTNAME=	dvipdfmx
PORTVERSION=	20160705
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	An extended version of dvipdfm

RUN_DEPENDS=	${LOCALBASE}/share/texmf-dist/fonts/map/glyphlist/glyphlist.txt:${PORTSDIR}/print/texlive-glyphlist \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
