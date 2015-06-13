# $FreeBSD$

PORTNAME=	texdirflatten
PORTVERSION=	20150413
CATEGORIES=	print

MAINTAINER=	romain@FreeBSD.org
COMMENT=	Collect files related to a LaTeX job in a single directory.

RUN_DEPENDS=	${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

OPTIONS_DEFINE=	DOCS
.include <bsd.port.options.mk>

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
