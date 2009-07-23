# New ports collection makefile for:	texlive-bin-amstex
# Date created:		26/01/2009 16:10:24
# Whom:		romain@blogreen.org
#
# $FreeBSD$
#

PORTNAME=	bin-amstex
PORTREVISION=	1
CATEGORIES=	print

MAINTAINER=	romain@blogreen.org
COMMENT=	American Mathematical Society plain TeX macros.

RUN_DEPENDS=	${LOCALBASE}/share/texmf/fmtutil/format.tex.cnf:${PORTSDIR}/print/texlive-bin-tex \
		${LOCALBASE}/bin/tex:${PORTSDIR}/print/texlive-core

LSE_LZMA=	yes
NOPORTSRC=	yes

.include "${.CURDIR}/../../print/texlive-core/bsd.texlive.mk"
.include <bsd.port.mk>
