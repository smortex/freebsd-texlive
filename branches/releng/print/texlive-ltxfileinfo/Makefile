# $FreeBSD$

PORTNAME=	ltxfileinfo
PORTVERSION=	20150123
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Print version information for a LaTeX file.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
